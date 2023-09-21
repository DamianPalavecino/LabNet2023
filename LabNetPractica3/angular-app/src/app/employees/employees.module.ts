import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeListComponent } from './components/employee-list/employee-list.component';
import { EmployeeApiService } from './services/employee-api.service';



@NgModule({
  declarations: [
    EmployeeListComponent,
  ],
  exports: [EmployeeListComponent],
  imports: [
    CommonModule
  ],
  providers: [
    EmployeeApiService
  ]
})
export class EmployeesModule { }
