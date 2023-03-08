// Para efecto de los cálculos correspondientes al perímetro de las figuras no considerar las líneas punteadas, para el área si

double GetArea(double l) {
    var areaCuadrado = Math.Pow(l,2);
    var areaSemiCirculo = (Math.PI * Math.Pow(l/2, 2))/2;
    var areaCuadradoChico = Math.Pow(l/5,2);
    var areaReactangulo = ((l/5)*((l*3)/5));
    return Math.Round((areaCuadrado + (2*areaCuadradoChico) + (2*areaReactangulo) + areaSemiCirculo), 4);
}

double GetPerimetro(double l) {
    var perimetroRectangulos = 2*((l/5)*2+(3*l)/5);
    var perimetroCuadrados = 2*(3*(l/5));
    var perimetroHuecos = 7*(l/5);
    var perimetroSemiCirculo = (2*Math.PI*(l/2))/2;
    return Math.Round(perimetroCuadrados + perimetroHuecos + perimetroRectangulos + perimetroSemiCirculo, 4);
}

Console.WriteLine("Ejercicio A");
Console.WriteLine($"El area total de la figura es de {GetArea(7)}");
Console.WriteLine($"El perimetro total de la figura es de {GetPerimetro(7)}");