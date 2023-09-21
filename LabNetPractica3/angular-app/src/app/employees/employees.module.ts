import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeListComponent } from './components/employee-list/employee-list.component';
import { EmployeeDetailsComponent } from './components/employee-details/employee-details.component';
import { EmployeeApiService } from './services/employee-api.service';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { EmployeeCreateComponent } from './components/employee-create/employee-create.component';



@NgModule({
  declarations: [
    EmployeeListComponent,
    EmployeeDetailsComponent,
    EmployeeCreateComponent
  ],
  exports: [EmployeeListComponent, EmployeeDetailsComponent, EmployeeCreateComponent],
  imports: [
    CommonModule,
    RouterModule,
    ReactiveFormsModule
  ],
  providers: [
    EmployeeApiService
  ]
})
export class EmployeesModule { }
