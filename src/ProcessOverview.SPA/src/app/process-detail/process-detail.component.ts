import { Component, OnInit } from '@angular/core';
import { Process } from "src/process";
import { Injectable } from '@angular/core';

@Injectable()
export class SelectedProcessService {
  public selectedProcess: any | undefined;
}

@Component({
  selector: 'app-process-detail',
  templateUrl: './process-detail.component.html',
  styleUrls: ['./process-detail.component.css']
})

export class ProcessDetailComponent implements OnInit {
  dataItem: Process | undefined;
  header: string = "";

  constructor(private selectedProcessService: SelectedProcessService) {}

  public ngOnInit() {
    this.dataItem = this.selectedProcessService.selectedProcess;
    console.log(this.dataItem);
    this.header = this.dataItem != undefined ? this.dataItem.processName : "No data found";
  }
}
