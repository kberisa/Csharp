//Console.Write("Unesite  broj: ");
//int broj = int.Parse(Console.ReadLine());

//// algoritam
//broj = broj + 7;

//// Izlaz
//Console.WriteLine(broj);

//*********************************************************************

////////// 1. zadatak
////////// Korisnik unosi cijeli broj
////////// Za broj manji od 10
////////// ispisuje se Osijek
////////// inače se ispisuje Donji Miholjac

//int b;

//Console.Write("Unesi broj: ");

//b = int.Parse(Console.ReadLine());
//if (b < 10)
//{
//    Console.WriteLine("Osijek");
//}
//else

//    Console.WriteLine("Donji miholjac");

//********************************************************************

////////// 2. zadatak
////////// Korisnik unosi cijeli broj
////////// Program ispisuje da li je 
////////// paran ili nije

//int g;
//Console.Write("Unesi cijeli broj: ");

//g= int.Parse(Console.ReadLine());

//Console.WriteLine("12: Broj je " + (g % 2 == 0 ? "" : "Ne") + "paran");

//**********************************************************************

////////// 3. zadatak
////////// Za dva unesena cijela broja
////////// program ispisuje Osijek
////////// ako je zbroj veći od 10
////////// inače ispisuje Edunova

//int pb;
//int db;
//Console.Write("Unesi prvi broj: ");
//pb= int.Parse(Console.ReadLine());

//Console.Write("Unesi drugi broj: ");
//db= int.Parse(Console.ReadLine());

//int zbroj = pb + db;

//if (zbroj <= 10)
//{
//    Console.WriteLine("Edunova");
//}
//else
//{
//    Console.WriteLine("Osijek");
//}

//**************************************************************************

//////////// Za unesena dva cijela broj
//////////// program ispisuje veći

//int b1;
//int b2;

//Console.Write("Unesi prvi broj: ");
//b1= int.Parse(Console.ReadLine());

//Console.Write("Unesi drugi broj: ");
//b2 = int.Parse(Console.ReadLine());

//if (b1 > b2)
//{
//    Console.WriteLine(b1);
//}
//else
//{
//    Console.WriteLine(b2);
//}

//*****************************************************************************

//////////// Za upisana 3 cijela broja
//////////// program ispisuje najveći

//int b1;
//int b2;
//int b3;

//Console.Write("Prvi: ");
//b1= int.Parse(Console.ReadLine());
//Console.Write("Drugi: ");
//b2 = int.Parse(Console.ReadLine());
//Console.Write("Treci: ");
//b3 = int.Parse(Console.ReadLine());


//if (b1 > b2 && b1> b3)
//{
//    Console.WriteLine(b1);
//}
//if (b2 > b3 && b2 > b1)
//{
//    Console.WriteLine(b2);
//}
//else if (b3 > b1 && b3 > b2)
//{
//    Console.WriteLine(b3);
//}

//*********************************************************************************

////////// program unosi broj između 
////////// 1 i 999
////////// U slučaju da je izvan tog raspona
////////// ispisati grešku i prekinuti program
////////// Program ispisuje 1. znamenku upisanog broja

//{Random i = new Random();

//int r = i.Next(1,999);

//    int zadnji = (r % 10);

//    while (true)
//    { 

//        if (r > 999)
//         {
//            Console.WriteLine("Greska");
//            break;
//         }
//        else
//        {
//            Console.WriteLine(zadnji);
//            break;
//        }
//        }
//    }

//************************************************************************************

//////////// Program unosi 2 broja
//////////// Ako su oba broja parni
//////////// ispisuje njihov zbroj
//////////// inače ispisuje njihovu razliku

//Random c = new Random();
//int d = c.Next(1, 99999);

//Random e = new Random();
//int f = e.Next(1, 99999);
//int g = (d + f);
//int h;
//h = Math.Abs(d - f);
//Console.WriteLine(d);
//Console.WriteLine(f);

//if (d % 2 == 0 && f % 2 == 0)
//{
//    Console.WriteLine(g);
//}
//else
//{
//    Console.WriteLine(h);
//}
