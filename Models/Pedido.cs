using System;
using System.Collections.Generic;
using System.Linq;


public class Pedido
{
    private List<ItemPedido> _itemPedidos;

    public Pedido()
    {
        _itemPedidos = new List<ItemPedido>();
    }

    public void AddPedido(ItemPedido itemPedido)
    {
        _itemPedidos.Add(itemPedido);
    }

    public void TotalPedido()
    {
        foreach (ItemPedido x in _itemPedidos)
        {
            Console.WriteLine("Produto: {0} - Valor Unitário: {1} - Quantidade: {2} - Total: {3}",
                x.Descricao, x.ValorUnitario, x.Quantidade, x.Total);
        }
    }

    public List<ItemPedido> ListaPedido()
    {
        return _itemPedidos;
    }

    public double Total()
    {
        return _itemPedidos.Sum(o => o.Total);
    }
}