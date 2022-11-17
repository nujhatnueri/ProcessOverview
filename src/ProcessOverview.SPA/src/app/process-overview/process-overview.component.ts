import { Component, OnInit } from '@angular/core';
import { SharedService } from "src/app/shared.service";
import { Process } from "src/process";
import { Router } from '@angular/router';
import { SelectedProcessService } from "src/app/process-detail/process-detail.component";

@Component({
  selector: 'app-process-overview',
  templateUrl: './process-overview.component.html',
  styleUrls: ['./process-overview.component.css']
})

export class ProcessOverviewComponent implements OnInit {
  processList:Process[] = [];  
  process:any;
  searchText='';
  
  constructor(private sharedService: SharedService, private router: Router, private selectedProcessService : SelectedProcessService) { }

  ngOnInit(): void {
    this.refreshProcesstList();
    this.selectedProcessService.selectedProcess = undefined;
  }

  refreshProcesstList() {
    this.sharedService.getProcessOverview().subscribe(data =>{      
      this.processList = data;
    });
  }  

  showDetail(clickedItem : any)
  {
    this.selectedProcessService.selectedProcess = clickedItem;    
    this.router.navigateByUrl('/process-detail');
  }
}
