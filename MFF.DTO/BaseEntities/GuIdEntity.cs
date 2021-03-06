﻿using MFF.DTO.Helpers;
using System.ComponentModel.DataAnnotations;

namespace MFF.DTO.BaseEntities
{
    public class GuIdEntity : BaseEntity
    {
        public GuIdEntity()
        {
            Id = CommonHelper.NewGuid();
        }

        [Key]
        public string Id { get; set; }
    }
}
