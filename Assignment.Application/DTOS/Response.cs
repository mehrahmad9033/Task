using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment.Application.DTOS
{
    public class Response<T>
    { 
        public bool Succeeded { get; set; }
        public string Message { get; set; } 
        public T Data { get; set; }
    } 
}
