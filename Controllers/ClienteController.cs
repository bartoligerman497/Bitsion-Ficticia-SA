using Bitsion_Ficticia_S.A.Models.Cliente;
using Bitsion_Ficticia_S.A.Models.Cliente.Genero;
using Bitsion_Ficticia_S.A.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitsion_Ficticia_S.A.Controllers
{
    public class ClienteController : Controller
    {
        private GBDCliente gBDCliente = new();
        private GBDGenero gBDGenero = new();

        public ActionResult ListadoClientes()
        {
            DTOModel dto = new();

            dto.ListadoClientes = gBDCliente.CargarListadoClientes(); ;

            return View(dto);
        }

        public ActionResult AltaCliente(int? idCliente)
        {
            List<GeneroModel> generos = gBDGenero.CargarComboGenero();

            ViewBag.Generos = generos;

            DTOModel dto = new();

            if (idCliente == 0 || idCliente == null)
            {
                return View(dto);
            }
            else
            {
                dto = gBDCliente.ObtenerClientexIdCliente(idCliente);
                if (dto == null)
                {
                    return NotFound();
                }
                return View(dto);
            }
        }

        [HttpPost]
        public IActionResult AltaCliente(DTOModel dto)
        {
            if (dto.Cliente.IdCliente == 0)
            {
                bool exitoAgregarCliente;

                exitoAgregarCliente = gBDCliente.AgregarCliente(dto.Cliente);
                dto.Cliente.IdCliente = gBDCliente.ObtenerUltimoIDCliente();

                if (exitoAgregarCliente)
                {
                    return RedirectToAction("ConsultaCliente", "Cliente", new { idCliente = dto.Cliente.IdCliente });
                }
                else
                {
                    return RedirectToAction("ListadoClientes", "Cliente");
                }
            }
            else
            {
                bool exitoModificarCliente;

                exitoModificarCliente = gBDCliente.ModificarCliente(dto.Cliente);

                if (exitoModificarCliente)
                {
                    return RedirectToAction("ConsultaCliente", "Cliente", new { idCliente = dto.Cliente.IdCliente });
                }
                else
                {
                    return RedirectToAction("ListadoClientes", "Cliente");
                }
            }
        }

        public ActionResult DeshabilitarCliente(int idCliente)
        {
            gBDCliente.DeshabilitarCliente(idCliente);

            return RedirectToAction("ListadoClientes", "Cliente");
        }

        [HttpPost]
        public IActionResult DeshabilitarCliente(ClienteModel cliente)
        {
            return View("ListadoClientes");
        }

        [HttpPost]
        public IActionResult ListadoClientes(DTOModel dto)
        {
            dto.ListadoClientes = new();

            return View(dto);
        }

        public ActionResult ConsultaCliente(int? idCliente)
        {
            List<GeneroModel> generos = gBDGenero.CargarComboGenero();

            ViewBag.Generos = generos;

            if (idCliente == 0 || idCliente == null)
            {
                DTOModel dto = new();

                return View(dto);
            }
            else
            {
                DTOModel dto = new();

                dto = gBDCliente.ObtenerClientexIdCliente(idCliente);

                if (dto == null)
                {
                    return NotFound();
                }
                return View(dto);
            }
        }

        [HttpPost]
        public IActionResult ConsultaCliente(DTOModel dto)
        {
            return View();
        }

        // GET: ClienteController
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
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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