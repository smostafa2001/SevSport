using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevSport.DAL.Entities.AccountAggregate;
public class Province
{
    public byte Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<District> Districts { get; set; } = [];
}