using System;
using System.Collections.Generic;
using System.Text;

namespace BlazingChat.Shared
{
    public class Contract {

        public int ContractId { get; set;}
        public string Vorname { get; set;}
        public string Nachname { get; set;}

        public Contract(){

        }

        public Contract(int contractId, string vorname, string nachname)
        {
            this.ContractId = contractId;
            this.Vorname = vorname;
            this.Nachname = nachname;
        }
    }
}