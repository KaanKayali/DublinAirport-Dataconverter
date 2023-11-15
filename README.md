# DublinAirport-Dataconverter
Thats a small c# project to convert and measure data from one to another excel file. Made for the dublin airport in an internship.

## Calculations
There are a few datasets given in an excel or CSV file and the purpose of this application is to load the file in and get another file automatically with new calculated values.
Its for the staff of the dublin airport to have more freetime by not calculatiing the datasets by themselves.
```
Total Demand = 1.44 * Total required
FTE = Total Demand / 40
HeadCount = FTE * 1.15
```
The Winforms programm makes a table preview where you can decide for which time intervall you want to download the new excel file. 
- [x] Daily
- [ ] Weekly
- [ ] Monthly
- [ ] Yearly

The Time intervall summens the data together.
