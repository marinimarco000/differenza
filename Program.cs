namespace differenza
{
    internal class Program
    {
        static int sommaq(int a, int b)
        {
            int somma = 0, sommaqq = 0;

            for (int i = a; i <= b; i++)  
            {
                sommaqq=sommaqq+(i*i);
            }
            return sommaqq;   
        }
        static int quadsom(int a,int b )
        {
            int quadsomm=0;
            for (int i = a; i <= b; i++)
            {
                quadsomm = quadsomm+i;
                
                
            }
            
            
            return quadsomm*quadsomm;    
        }

        static void Main(string[] args)
        {
            int differenza;
            Console.WriteLine("dimmi il primo numero dal quale inizia l'intervallo  ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dimmi il secondo  numero  dal quale finisce intervallo ");
            int n2 = Convert.ToInt32(Console.ReadLine());


            differenza = sommaq(n1, n2) -quadsom(n1, n2);
            Console.WriteLine("differenza fa " + differenza);

        }
    }
}
