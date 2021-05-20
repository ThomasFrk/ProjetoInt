using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoCar.Models;
using LoCar.Data;


namespace LoCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        
       private readonly LoCarContext _context;

        public ClienteController(LoCarContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            Console.WriteLine("Creating Cliente...");

            return View();
        }

        // [HttpPost]
        // public async Task<IActionResult> Create([Bind("Id,Nome,Nascimento,Cpf, Endereço, Email, Senha")] Cliente clienteOne)
        // {
        //         Console.WriteLine("Creating Cliente...");
        //         _context.Add(clienteOne);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
            
        //     // return View(cliente);
        // }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Post([FromBody] Cliente cliente)//recebe um produto do body do Http e não do header
        {
            try
            {
                var newCliente = new Cliente
                {
                    Id=Convert.ToInt32(cliente.Id),
                    Nome=cliente.Nome,
                    Endereco=cliente.Endereco,
                   
                };
                _context.Add(newCliente);
                await _context.SaveChangesAsync();//insere na tabela
                return Ok();

            }
            catch (Exception e)
            {
                return View(e);
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}