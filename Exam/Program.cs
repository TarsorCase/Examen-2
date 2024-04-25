int yes = 1; 
while(yes == 1){
  Console.WriteLine("\n***** CALCULADORA *****");
  Console.WriteLine("1 ---> MRU\n2 ---> MRUA\nSeleccione una opcion (1 - 2): ");
  int optionMr = Convert.ToInt32(Console.ReadLine());
  switch (optionMr)
  {
    case 1:  
    Console.WriteLine("1 ---> Distancia\n2 ---> Velocidad\n3 ---> Tiempo\nSeleccione una opcion (1 - 2 - 3): ");
    int optionMru = Convert.ToInt32(Console.ReadLine());
    float distancia;
    float tiempo;
    float velocidad;
    float pos_ini;
    double pos_fin;
    float velo_ini;
    float velo_fin;
    float aceleracion;
      switch (optionMru){
      case 1:
      Console.WriteLine("Ingrese la velocidad: ");
      velocidad = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la tiempo: ");
      tiempo = Convert.ToInt32(Console.ReadLine());
      distancia = velocidad * tiempo;
      Console.WriteLine($"La distancia es: {distancia}"); 
      break;
      case 2:
      Console.WriteLine("Ingrese la distancia: ");
      distancia = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese el tiempo: ");
      tiempo = Convert.ToInt32(Console.ReadLine());
      velocidad = distancia / tiempo;
      Console.WriteLine($"La velocidad es: {velocidad}"); 
      break;
      case 3:
      Console.WriteLine("Ingrese la distancia: ");
      distancia = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la velocidad: ");
      velocidad = Convert.ToInt32(Console.ReadLine());
      tiempo = distancia / velocidad;
      Console.WriteLine($"La velocidad es: {tiempo}"); 
      break;
      }
    break;
    case 2:
      Console.WriteLine("1 ---> Posicion final\n2 ---> Velocidad final\n3 ---> Tiempo\nSeleccione una opcion (1 - 2 - 3): ");
      int optionMrua = Convert.ToInt32(Console.ReadLine());
      switch (optionMrua){  
      case 1:
      Console.WriteLine("Ingrese la posicion inicial: ");
      pos_ini = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la velocidad inicial: ");
      velo_ini = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la tiempo: ");
      tiempo = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la aceleracion: ");
      aceleracion = Convert.ToInt32(Console.ReadLine());
      pos_fin = pos_ini+velo_ini*tiempo+0.5*aceleracion*Math.Pow(tiempo, 2);
      Console.WriteLine($"La posicion final es: {pos_fin}"); 
      break;
      case 2:
      Console.WriteLine("Ingrese la velocidad inicial: ");
      velo_ini = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la tiempo: ");
      tiempo = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la aceleracion: ");
      aceleracion = Convert.ToInt32(Console.ReadLine());
      velo_fin = velo_ini+ aceleracion* tiempo;
      Console.WriteLine($"La velocidad es: {velo_fin}"); 
      break;
      case 3:
      Console.WriteLine("Ingrese la velocidad final: ");
      velo_fin = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la velocidad inicial: ");
      velo_ini = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la aceleracion: ");
      aceleracion = Convert.ToInt32(Console.ReadLine());
      tiempo = (velo_fin - velo_ini) / aceleracion;
      Console.WriteLine($"El timepo es: {tiempo}"); 
      break;
      }
    break;
  }
  Console.WriteLine("Would you want to continue making calculations? 1 --> yes | 2 --> no\n");
  yes = Convert.ToInt32(Console.ReadLine());
}
if (yes == 2)
{
  Console.WriteLine("\nThank you for using this calculator :)");
  Console.WriteLine(" /\\_/\\");
  Console.WriteLine("( o.o )");  
  Console.WriteLine(" > ^ <");
  Console.WriteLine("All so shall you concive this phrase \"Cato\" but how may u use it?");
}
