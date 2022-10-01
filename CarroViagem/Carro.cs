using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroViagem
{   
    public enum RC //Retorno Combustivel 
    {
        VN = 0, // Valor Negativo
        VA = 1, // Valor Acima do normal
        CSG = 2, // Carro sem gasolina
        CA = 3, // Continua Andando
    }

    public enum AC //Adicionar Combustivel 
    {
        VC = 0, // Vazou Combustivel 
        COK = 1, // Combustivel OK!      
    }

    public class Carro
    {
        private float tanque;
        private float consumo = 0;
        private float distanciaKM = 0;
        private float qG = 0 ;

        public Carro(float consumo, float distanciaKM)
        {
            consumo = consumo;
            tanque = tanque;
            distanciaKM = distanciaKM;         
        }

        public float Tanque { get => tanque; set => tanque = value; }
        public float Consumo { get => consumo; set => consumo = value; }
      
        public float DistanciaKM { get => distanciaKM; set => distanciaKM = value; }
        public float qG1 { get => qG; set => qG = value; }

        public RC Andar (int KM)
        {
            if (KM <= 0)
                return RC.VN;
            if (KM > 1000)
                return RC.VA;

            float gastar = KM / consumo;
            
            if (qG > gastar)
                qG -= gastar;
            else
                return RC.CSG;

            distanciaKM += KM;
            return RC.CA;    
        }
        public float OG() // Obter Gasolina 
        {
            return qG;
        }
        public AC AG(float QLG) // Adicionar Gasolina e Quantidade Litro Gasolina
        {
           if ((qG + QLG) > tanque)
            return AC.VC;
           else
                qG+=QLG;
            return AC.COK;
        }
    }

}
