using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model;

public class Auto
{
    /// <summary>
    /// Registrační značka vozidla (SPZ)
    /// </summary>
    public string Spz { get; set; } = string.Empty;

    public string Barva { get; set; } = string.Empty;

    public int PocetDveri { get; set; }

    public TypPaliva Palivo { get; set; }

    /// <summary>
    /// Průměrná spotřeba vozidla v litrech na 100 km. 
    /// Přebráno od výrobce.
    /// </summary>
    public double Spotreba { get; set; }

    public byte VelikostKol { get; set; }

    public int VykonKw { get; set; }

    /// <summary>
    /// Brand vozidla, například "Toyota", "Ford", "BMW" apod.
    /// </summary>
    public string Vyrobce { get; set; } = string.Empty;

    /// <summary>
    /// Model vozidla, například "Corolla", "Focus", "3 Series" apod.
    /// </summary>
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Datum poslední technické kontroly (STK) vozidla.
    /// </summary>
    public DateTime DatumStk { get; set; }


    public override string ToString()
    {
        return $"Auto: {Spz}, {Vyrobce} {Model}, {Barva}, {PocetDveri} dveří, {Palivo}, {Spotreba} l/100km, {VelikostKol} in, {VykonKw} kW, STK: {DatumStk:dd. MM. yyyy}";
    }

}
