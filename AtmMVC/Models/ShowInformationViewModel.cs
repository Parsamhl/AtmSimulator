﻿using App.Domain.Core.Atm.Card.Entities;

namespace Quiz2.Endpoints.MVC.Models
{
    public class ShowInformationViewModel
    {
        public string SourceCardNumber { get; set; }
        public Card DestinationsCard { get; set; }
        public float Amount { get; set; }
        public string CodeVerify { get; set; }
    }
}
