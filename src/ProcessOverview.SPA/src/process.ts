export interface Process
{
    customerId : number;
    customerName :string;
        machineNr:string;
        machineId : number;
        machineType:string;
        serial :string;
        processName :string;
        startTime :string;
        endTime :string;
        onlineFrom :string;
        waterTempUnit :string;
        waterTemp : number;
        pump10 : boolean;
        pump5 : boolean;
        drainSensor: boolean;
        waterLevelUnit :string;
        waterLevel : number;
}