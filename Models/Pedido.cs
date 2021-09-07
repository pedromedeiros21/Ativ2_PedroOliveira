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

    public List<ItemPedido> ListaPedido()
    {
        return _itemPedidos;
    }

    public double Total()
    {
        return _itemPedidos.Sum(o => o.Total);
    }
}