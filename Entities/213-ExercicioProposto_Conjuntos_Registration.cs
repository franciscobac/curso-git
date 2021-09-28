using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCursoCSharp.Entities
{
    class Registration
    {
        public int Id { get; set; }

        public Registration(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Registration))
            {
                return false;
            }
            Registration other = obj as Registration;
            return Id.Equals(other.Id);
        }
    }
}
