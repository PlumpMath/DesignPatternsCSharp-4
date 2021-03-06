﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportChainOfResponsibilities
{
    class FlightManager:Approver
    {
        public override void ProcessRequest(Flight flight)
        {
            if (flight.Type == "Training" || flight.Type=="Aircraft")
            {
                Console.WriteLine("{0} approved request #{1}",
                   this.GetType().Name, flight.ModelPlane);
                Console.WriteLine("This flight is {0} , model of the plane is {1},weight of the plane is {2}, nationality: {3}", flight.Type, flight.ModelPlane, flight.Weight, flight.Nationality);
                Employee employee = new Employee("Petar", "Petrov", "flight manager", "service");
                Console.WriteLine("Your request was processed by: {0} {1} , {2},{3}  ", employee.Fname, employee.Lname, employee.Position, employee.Department);
            }
            else if (this.Successor != null)
            {
                this.Successor.ProcessRequest(flight);
            }
        }
    }
}
