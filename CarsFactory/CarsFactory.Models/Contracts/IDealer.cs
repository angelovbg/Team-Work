﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarsFactory.Models.Contracts
{
    public interface IDealer
    {
        int Id { get; }

        [Required]
        [MaxLength(50)]
        string Name { get; }

        ICollection<ICar> Cars { get; }
    }
}
