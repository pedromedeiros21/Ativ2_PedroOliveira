using System;
using System.Collections.Generic;

public class ItemPedido{

public string Descricao { get; set; }
public double ValorUnitario { get; set; }
public double Quantidade { get; set; }

public double Total { get { return ValorUnitario * Quantidade; } }

}