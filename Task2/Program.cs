//Напишите прогамму, которая принимает на вход координаты двух точек и находит
//расстояние между ними в 3D пространстве:
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5,0); B (1,-1,9) -> 11.53

int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Input ("Введите координату x1: ");
int x2 = Input ("Введите координату x2: ");
int y1 = Input ("Введите координату y1: ");
int y2 = Input ("Введите координату y2: ");
int z1 = Input ("Введите координату z1: ");
int z2 = Input ("Введите координату z2: ");

int lineX = x2 - x1;
int lineY = y2 - y1;
int lineZ = z2 - z1;

double line =  Math.Sqrt(lineX*lineX + lineY*lineY + lineZ*lineZ);

Console.WriteLine("Расстояние между двумя точками " + line);
