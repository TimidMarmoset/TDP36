using System;
using System.Collections.Generic;

namespace TDP36.Domain.Entities
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name {  get; set; }
        public int Awareness {  get; set; }
        public int Reflexes {  get; set; }
        public int Qi {  get; set; }
        public int Intelligence {  get; set; }
        public int Enlightenment {  get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Balance { get; set; }
    }
}
