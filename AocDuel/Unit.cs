using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AocDuel
{
  public class Unit
  {
    public int Id { get; set; }
    public int UnitClass { get; set; }
    public int Civilization { get; set; }
    public int LanguageDllName { get; set; }
    public int HitPoints { get; set; }
    public List<AttackArmor> Attacks { get; set; }
    public List<AttackArmor > Armors { get; set; }
    public int BaseArmor { get; set; }
  }
}
