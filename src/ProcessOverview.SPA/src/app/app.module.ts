import { NgModule } from '@angular/core';
import { Form } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProcessOverviewComponent } from './process-overview/process-overview.component';
import { ProcessDetailComponent } from './process-detail/process-detail.component';
import { SelectedProcessService } from "src/app/process-detail/process-detail.component";

import { HttpClientModule } from "@angular/common/http";
import { SharedService } from "./shared.service";
import { FormsModule,ReactiveFormsModule } from "@angular/forms";
import { SearchPipe } from './search.pipe';


@NgModule({
  declarations: [
    AppComponent,
    ProcessOverviewComponent,
    ProcessDetailComponent,
    SearchPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService ,
  SelectedProcessService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }