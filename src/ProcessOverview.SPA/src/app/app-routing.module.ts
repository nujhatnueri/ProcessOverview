import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProcessOverviewComponent } from "./process-overview/process-overview.component";
import { ProcessDetailComponent } from "./process-detail/process-detail.component";


const routes: Routes = [
  {path: '', redirectTo: '/process-overview', pathMatch: 'full'},
  {path:'process-overview', component:ProcessOverviewComponent},
  {path:'process-detail', component:ProcessDetailComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }