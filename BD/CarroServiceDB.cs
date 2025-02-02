namespace BD
{
    public class CarroServiceDB
    {
        private readonly Context context1;

        public CarroServiceDB(Context _context1)
        {
            context1 = _context1; 
        }

        public void AddCarro(Entidades.CarroDTO carro)
        {
            context1.Carro.Add(new Entidades.Carro()
            {
                Marca = carro.Marca,
                Modelo = carro.Modelo,
                Ano = carro.Ano,
                Tipo = carro.Tipo
            });
            context1.SaveChanges();
        }

        public List<Entidades.CarroDTO> GetCarros()
        {
            return context1.Carro.Select(c => new Entidades.CarroDTO()
            {
                Marca = c.Marca,
                Modelo = c.Modelo,
                Ano = c.Ano,
                Tipo = c.Tipo
            }).ToList();
        }
    }
}
