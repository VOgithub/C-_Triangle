using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinKolmNurk
{
    public class Triangle
    {
        public double A;
        public double B;
        public double C;
        public double S;  // ploshad
        public double H;  // visota

        public Triangle(double a, double b, double c)  ///construktor
        {
            A= a;
            B= b;
            C= c;
        }
        public Triangle(double s,double h)   //new constructor with ploshad i hight
        {
            S = s;
            H = h;
        }
        public Triangle()  // empty constructor
        {

        }
        public bool ExistTriangle   // is it a Triangle?
        {
            get 
            {
                if (A + B > C && A + C > B && B + C > A)
                {
                    return true;

                }
                else
                { 
                    return false;
                }
                    
            }
        }
        public double GetSetA
        { 
            get { return A; }
            set { A = value; }
        
        }
        public double GetSetB
        {
            get { return B; }
            set { B = value; }

        }
        public double GetSetC
        {
            get { return C; }
            set { C = value; }

        }
        public double GetSetS
        {
            get { return S; }
            set { S = value; }

        }
        public string TriangleType
        {
            get
            {
                if (ExistTriangle)
                {
                    if (A==B && B==C && A==C)
                    {
                        return "Ravnostoronnii !";
                    }
                    else if (A==B || A==C || B == C)
                    {
                        return "Ravnobedrennii !";
                    }
                    else
                    {
                        return "Raznostoronnii !";
                    }
                    
                }else
                {
                    return "tundmatu line !";
                }
                
            }
        }
        public double Perimeter()   ///perimeter 
        {
            return A+B+C;
        }
        public double Perimeter1_2()
        { 
            return (A+B+C)/2;
        }
        public double Area()   // return 0 if is not a triangle!
        {
            double s=0;   //
            if (ExistTriangle)
            {
                double p; // poluperimeter  !! 
                p=(A+B+C)/2;
                s= Math.Sqrt(p*(p-A)*(p-B)*(p-C));  //formula Herona for Triangle perimeter
            }
            return s;
        }
        public string OutputA()
        {
            return A.ToString();
        }
        public string OutputB()
        {
            return B.ToString();
        }
        public string OutputC()
        {
            return C.ToString();
        }

    }
}
