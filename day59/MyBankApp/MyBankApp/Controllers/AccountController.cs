using Azure.Identity;
using Azure.Messaging;
using Microsoft.AspNetCore.Mvc;
using MyBankApp.Models;
using System.Text;

namespace MyBankApp.Controllers
{
    public class AccountController : Controller
    {
        public static List<User> _users = new List<User>(); // Simulate a database
        public readonly AppDbContext _context;


        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);

                if (user != null)
                {
                    TempData["Username"] = model.Username;
                    TempData["CustomerId"] = user.CustomerId;

                    return RedirectToAction("Welcome", "Account");

                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }
            return View(model);
        }

        public IActionResult Welcome(int userid) //Pass user Id
        {
            var user = _context.Users.Find(TempData["CustomerId"]);
            if (user == null) { return NotFound(); }

            var transactions = _context.Transactions.Where(t => t.UserId == user.CustomerId);
            decimal balance = transactions.Any() ? transactions.OrderByDescending(t => t.TransactionDate).FirstOrDefault().Balance : 0;

            ViewBag.Balance = balance;
            ViewBag.UserId = user.CustomerId;

            return View(user);
        }



        [HttpPost]
        public IActionResult AddTransaction(int userId, string description, decimal amount, string transactionType)
        {
            var user = _context.Users.Find(userId);
            if (user == null) { return NotFound(); }

            var latestTransaction = _context.Transactions
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.TransactionDate)
                .FirstOrDefault();

            decimal currentBalance = latestTransaction?.Balance ?? 0;
            decimal newBalance = transactionType == "credit" ? currentBalance + amount : currentBalance - amount;

            var transaction = new Transaction
            {
                UserId = userId,
                Description = description,
                Credit = transactionType == "credit" ? amount : 0,
                Debit = transactionType == "debit" ? amount : 0,
                Balance = newBalance,
                TransactionDate = DateTime.Now
            };

            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            return RedirectToAction("Welcome", new { userId });
           



        }

        public IActionResult Transactions(int userId, DateTime? fromDate, DateTime? toDate)
        {
            var transactionsQuery = _context.Transactions.Where(t => t.UserId == userId);

            if (fromDate.HasValue)
            {
                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate >= fromDate.Value.Date);
            }

            if (toDate.HasValue)
            {
                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate <= toDate.Value.Date.AddDays(1).AddSeconds(-1));
            }

            var transactions = transactionsQuery.OrderByDescending(t => t.TransactionDate).ToList();

            ViewBag.UserId = userId;
            ViewBag.FromDate = fromDate?.ToString("yyyy-MM-dd");
            ViewBag.ToDate = toDate?.ToString("yyyy-MM-dd");

            return View(transactions);
        }

        public IActionResult DownloadCsv(int userId, DateTime? fromDate, DateTime? toDate)
        {
            var transactionsQuery = _context.Transactions.Where(t => t.UserId == userId);

            if (fromDate.HasValue)
            {
                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate >= fromDate.Value.Date);
            }

            if (toDate.HasValue)
            {
                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate <= toDate.Value.Date.AddDays(1).AddSeconds(-1));
            }

            var transactions = transactionsQuery.OrderByDescending(t => t.TransactionDate).ToList();

            var csv = new StringBuilder();
            csv.AppendLine("Id,Description,Debit,Credit,Balance,TransactionDate");

            foreach (var transaction in transactions)
            {
                csv.AppendLine($"{transaction.Id},{transaction.Description},{transaction.Debit},{transaction.Credit},{transaction.Balance},{transaction.TransactionDate}");
            }

            return File(Encoding.UTF8.GetBytes(csv.ToString()), "text/csv", "transactions.csv");
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(User model)
        {
            if (ModelState.IsValid)
            {
                // Check if username already exists
                if (_context.Users.Any(u => u.Username == model.Username))
                {
                    ModelState.AddModelError("Username", "Username already exists.");
                    return View(model);
                }
                _context.Users.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Login");
            }
            return View(model);
        }



        //public IActionResult Welcome()
        //{

        //    return View();
        //}
    }
}
