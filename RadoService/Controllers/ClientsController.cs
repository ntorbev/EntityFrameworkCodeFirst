using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RadoService.DAl;
using RadoService.Models;


namespace RadoService.Controllers
{
    public class ClientsController : Controller
    {
        //
        // GET: /Clients/

        public ActionResult List()
        {

            List<Client> clients = RadoServiceDAL.GetAllClients();
            List<ClientsViewModel> clientsViewModel = new List<ClientsViewModel>();

            foreach (var client in clients)
            {
                clientsViewModel.Add(
                    new ClientsViewModel(client)
                    );
            }


            //ViewBag.Massage = "radi clients";
            return View(clientsViewModel);
        }
    }
}
