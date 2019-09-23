﻿using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    [Table("Lecturers")]
    public class Lecturer : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public string CardId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public bool Sex { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        // quốc gia
        [Required]
        public string Nationality { get; set; }

        // tình trạng hôn nhân
        [Required]
        public int MarritalStatus { get; set; }

        // kinh nghiệm
        public string ExperienceRecord { get; set; }

        public string Email { get; set; }

        public string Facebook { get; set; }

        [Column(TypeName = "VARCHAR(16)")]
        public string Phone { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Certificate { get; set; }

        [Required]
        public string Image { get; set; }

        // lương cơ bản
        [Required]
        public decimal BasicSalary { get; set; }

        // phụ cấp
        [Required]
        public decimal Allowance { get; set; }

        // tiền thưởng
        [Required]
        public decimal Bonus { get; set; }

        // tiền bảo hiểm
        [Required]
        public decimal InsurancePremium { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        [Required]
        public Status Status { get; set; }

        public string Note { get; set; }

        //ngày nghỉ việc
        public DateTime QuitWorkDay { get; set; }


        // giáo viên thỉnh giảng
        [Required]
        public bool IsVisitingLecturer { get; set; }

        // trợ giảng
        [Required]
        public bool IsTutor { get; set; }
    }
}