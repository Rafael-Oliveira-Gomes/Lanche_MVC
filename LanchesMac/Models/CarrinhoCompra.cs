﻿using LanchesMac.Context;

namespace LanchesMac.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;


        //Injeta o contexto no construtor
        public CarrinhoCompra(AppDbContext contexto)
        {
            _context = contexto;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }



        public static CarrinhoCompra GetCArrinho(IServiceProvider services)
        {
            //define uma sessão
            ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            //obtem ou gera o id do carrinho
            string carrinhoid = session.GetString("CarrinhoId")??Guid.NewGuid().ToString();

            //atribui o id do carrinho na Sessão
            session.SetString("CarrinhoId", carrinhoid);

            //retorna o carrinho com o contexto e o id atribuído ou obtido
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoid,
            };

        }
    }
}