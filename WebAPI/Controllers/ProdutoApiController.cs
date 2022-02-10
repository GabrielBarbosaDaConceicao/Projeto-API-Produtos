using Data.Entidades;
using Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Authorize]
    public class ProdutoApiController : Controller
    {
        private readonly IProduto IProduto;
        public ProdutoApiController(IProduto IProduto)
        {
            this.IProduto = IProduto;
        }


        [HttpGet("/api/ListaProdutos")]
        public async Task<JsonResult> ListaProdutos()
        {
            return Json(await this.IProduto.list());
        }
        
        
        [HttpPost("/api/AdicionarProduto")]
        public async Task AdicionarProduto([FromBody] Produto produto)
        {
            await Task.FromResult(this.IProduto.Add(produto));
        }
    }
}
