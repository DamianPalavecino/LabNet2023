import { Component, OnInit } from '@angular/core';
import Employee from '../../models/employees';
import { EmployeeApiService } from '../../services/employee-api.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  employees: Employee[] = [];

  constructor(private employeeApiService: EmployeeApiService) {
   }

   ngOnInit(): void {
    this.getAllEmployees();
  }

   getAllEmployees() {
    this.employeeApiService.getEmployees().subscribe((data) => {
      this.employees = data;
    });
  }

}
