import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EmployeeApiService } from '../../services/employee-api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employee-create',
  templateUrl: './employee-create.component.html',
  styleUrls: ['./employee-create.component.css']
})
export class EmployeeCreateComponent implements OnInit {
  employeeForm!: FormGroup;
  message: string | null = null;

  constructor(
    private fb: FormBuilder,
    private employeeApiService: EmployeeApiService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.employeeForm = this.fb.group({
      Nombre: ['', Validators.required],
      Apellido: ['', Validators.required],
      Titulo: ['', Validators.required]
    });
  }

  onFormSubmit() {
    if (this.employeeForm.valid) {
      const employeeData = this.employeeForm.value;

      this.employeeApiService.createEmployee(employeeData).subscribe(() => {
        this.message = 'El empleado fue correctamente creado';
        this.router.navigate(['/employees']);
      });
    }
  }
}
