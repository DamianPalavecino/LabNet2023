import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeListComponent } from './employees/components/employee-list/employee-list.component';
import { EmployeeDetailsComponent } from './employees/components/employee-details/employee-details.component';
import { EmployeeCreateComponent } from './employees/components/employee-create/employee-create.component';
import { EmployeeEditComponent } from './employees/components/employee-edit/employee-edit.component';

const routes: Routes = [
  { path: '', redirectTo: '/employees', pathMatch: 'full' },
  { path: 'employees', component: EmployeeListComponent },
  { path: 'employees/create', component: EmployeeCreateComponent },
  { path: 'employees/edit/:id', component: EmployeeEditComponent },
  { path: 'employees/:id', component: EmployeeDetailsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
