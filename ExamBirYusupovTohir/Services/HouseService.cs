using ExamBirYusupovTohir.Models;

namespace ExamBirYusupovTohir.Services;

public class HouseService
{
    private List<House> houses;

    public HouseService()
    {
        houses = new List<House>();
    }

    public bool AddHouse(House house)
    {
        var checkHouse = true;
        foreach (var item in houses)
        {
            if (item.Id == house.Id)
            {
                checkHouse = false;
                break;
            }
        }
        houses.Add(house);

        return checkHouse;
    }

    public House GetHouseById(Guid houseId)
    {
        foreach (var house in houses)
        {
            if (house.Id == houseId)
            {
                return house;
            }
        }

        throw new Exception("bunaqa id li house yo'q");
    }

    public bool DeleteHouse(Guid houseId)
    {
        var deletedHouse = GetHouseById(houseId);

        houses.Remove(deletedHouse);

        return true;
    }

    public bool UpdateHouse(House oldHouse, House newHouse)
    {

        var updatedHouse = GetHouseById(oldHouse.Id);

        updatedHouse.Location = newHouse.Location;
        updatedHouse.Price = newHouse.Price;
        updatedHouse.Description = newHouse.Description;

        return true;
    }

    public List<House> GetHouseList()
    {
        return houses;
    }
}

