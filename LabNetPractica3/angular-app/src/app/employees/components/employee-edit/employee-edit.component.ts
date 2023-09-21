import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import Employee from '../../models/employees';
import { EmployeeApiService } from '../../services/employee-api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employee-edit',
  templateUrl: './employee-edit.component.html',
  styleUrls: ['./employee-edit.component.css']
})
export class EmployeeEditComponent implements OnInit {
  employeeForm!: FormGroup;
  employeeId!: number;
  employee: Employee | undefined;
  message: string | null = null;

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private employeeApiService: EmployeeApiService
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      const idParam = params.get('id');
      if (idParam !== null) {
        const id = +idParam;
        if (!isNaN(id)) {
          this.employeeId = id;
          this.getEmployeeById(id);
        }
      }
    });

    this.employeeForm = this.fb.group({
      Nombre: ['', Validators.required],
      Apellido: ['', Validators.required],
      Titulo: ['', Validators.required]
    });
  }

  getEmployeeById(id: number): void {
    this.employeeApiService.getEmployeeById(id).subscribe((employee) => {
      this.employee = employee;
      this.employeeForm.patchValue(employee);
    });
  }

  onFormSubmit() {
    if (this.employeeForm.valid) {
      const employeeData = this.employeeForm.value;
      employeeData.Id = this.employeeId;

      this.employeeApiService.updateEmployee(employeeData).subscribe(() => {
        this.message = 'El empleado fue modificado correctamente.';
        this.router.navigate(['/employees']);
      });
    }
  }
}
