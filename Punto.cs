using System;

class Punto {
    //constructor sin param
    public Punto(){
    Console.WriteLine("Este es el constructor por defecto");
  }
    //constructor con param
    public Punto(int x, int y){
      Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
    }  

  
}