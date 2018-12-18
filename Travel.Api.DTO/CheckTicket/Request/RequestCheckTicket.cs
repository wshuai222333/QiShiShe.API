using System;
using System.ComponentModel.DataAnnotations;

namespace Travel.Api.DTO.CheckTicket.Request {
    public class RequestCheckTicket : RequestBaseModel {
        [Required(ErrorMessage = "必须填写")]
        public string TicketNumber { get; set; }
        [Required(ErrorMessage = "必须填写")]
        public string Name { get; set; }
        [Required(ErrorMessage = "必须填写")]
        public DateTime RequestTime { get; set; }
    }
}
