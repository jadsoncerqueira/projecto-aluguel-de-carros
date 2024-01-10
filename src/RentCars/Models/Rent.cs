using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    //10 - Crie o construtor de `Rent` seguindo as regras de negócio
    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        Person = person;
        Vehicle = vehicle;
       double preco = vehicle.PricePerDay * daysRented;
       if(person is LegalPerson) {
        preco -= preco / 100 * 10  ;
       } ;
       Price = preco;
       Status = RentStatus.Confirmed;
       Vehicle.IsRented = true;
       Person.Debit = preco;
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Cancel()
    {
        throw new NotImplementedException();
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Finish()
    {
        throw new NotImplementedException();
    }
}