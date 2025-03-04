﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDB.Entity.FRONTEND_RESERVATIONDB
{
    public class Reservation
    {
		public int Id { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string birth_day { get; set; }
		public string gender { get; set; }
		public string phone_number { get; set; }
		public string email_address { get; set; }
		public int    number_guest { get; set; }
		public string street_address { get; set; }
		public string apt_suite { get; set; }
		public string city { get; set; }
		public string state { get; set; }
		public string zip_code { get; set; }
		public string room_type { get; set; }
		public string room_floor { get; set; }
		public string room_number { get; set; }
		public float total_bill { get; set; }
		public string payment_type { get; set; }
		public string card_type { get; set; }
		public string card_number { get; set; }
		public string card_exp { get; set; }
		public string card_cvc { get; set; }
		public DateTime arrival_time { get; set; }
		public DateTime leaving_time { get; set; }
		public bool check_in { get; set; }
		public int break_fast { get; set; }
		public int lunch { get; set; }
		public int dinner { get; set; }
		public bool cleaning { get; set; }
		public bool towel { get; set; }
		public bool s_surprise { get; set; }
		public bool supply_status { get; set; }
		public int food_bill { get; set; }

	}
}
