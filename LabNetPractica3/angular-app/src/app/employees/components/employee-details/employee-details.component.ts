import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import Employee from '../../models/employees';
import { EmployeeApiService } from '../../services/employee-api.service';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {
  employee: Employee | undefined;

  constructor(private route: ActivatedRoute,
    private employeeApiService: EmployeeApiService) { }

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.getEmployeeById(+id);
      console.log(id);
    }
  }

  getEmployeeById(id: number): void {
    this.employeeApiService.getEmployeeById(id).subscribe((data) => {
      console.log(data);
      this.employee = data;
    });
  }

}
