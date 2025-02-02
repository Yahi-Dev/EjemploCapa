using BD;

namespace Service
{
    public class CarroService
    {
        public readonly CarroServiceDB carroServiceDB;

        public CarroService(CarroServiceDB _carroServiceDB)
        {
            carroServiceDB = _carroServiceDB;
        }

        public void AddCarro(Entidades.CarroDTO carro)
        {
            carroServiceDB.AddCarro(carro);
        }
    }
}
