Imports System.Collections.ObjectModel
Imports System.ComponentModel.DataAnnotations

Namespace ConditionalFormatting

    Public Class SaleData

        Public Property State As String

        <DisplayFormat(DataFormatString:="#,##0,,M")>
        Public Property Sales As Double

        <DisplayFormat(DataFormatString:="p", ApplyFormatInEditMode:=True), Display(Name:="Sales vs Target")>
        Public Property SalesVsTarget As Double

        <DisplayFormat(DataFormatString:="#,##0,,M")>
        Public Property Profit As Double

        Public Property CustomersSatisfaction As Double

        <DisplayFormat(DataFormatString:="p0", ApplyFormatInEditMode:=True)>
        Public Property MarketShare As Double
    End Class

    Public Module SaleDataModel

        Public Function GetSales() As ObservableCollection(Of SaleData)
            Return New ObservableCollection(Of SaleData) From {New SaleData() With {.State = "California", .Sales = 467949484.42, .SalesVsTarget = 0.027697392, .Profit = 44000000, .CustomersSatisfaction = 4.6, .MarketShare = .34}, New SaleData() With {.State = "South Dakota", .Sales = 458113868.36, .SalesVsTarget = 0.048206741, .Profit = 27000000, .CustomersSatisfaction = 4.8, .MarketShare = .32}, New SaleData() With {.State = "Ohio", .Sales = 250772304.63, .SalesVsTarget = -0.028834951, .Profit = -15000000, .CustomersSatisfaction = 3.4, .MarketShare = .29}, New SaleData() With {.State = "Wisconsin", .Sales = 182660621.53, .SalesVsTarget = 0.059826898, .Profit = 14000000, .CustomersSatisfaction = 4.1, .MarketShare = .22}, New SaleData() With {.State = "New Hampshire", .Sales = 158710257.91, .SalesVsTarget = 0.01329949, .Profit = 10000000, .CustomersSatisfaction = 4.0, .MarketShare = .19}, New SaleData() With {.State = "Maine", .Sales = 156032947.24, .SalesVsTarget = -0.099670575, .Profit = -9000000, .CustomersSatisfaction = 2.9, .MarketShare = .14}, New SaleData() With {.State = "Utah", .Sales = 131496479.72, .SalesVsTarget = 0.044533577, .Profit = 18000000, .CustomersSatisfaction = 4.7, .MarketShare = .27}, New SaleData() With {.State = "Idaho", .Sales = 119199535.50, .SalesVsTarget = 0.006545225, .Profit = 14000000, .CustomersSatisfaction = 3.9, .MarketShare = .30}, New SaleData() With {.State = "Illinois", .Sales = 102480457.66, .SalesVsTarget = -0.003925837, .Profit = 9000000, .CustomersSatisfaction = 4.2, .MarketShare = .17}, New SaleData() With {.State = "Washington", .Sales = 102301309.53, .SalesVsTarget = 0.024232883, .Profit = 18000000, .CustomersSatisfaction = 4.6, .MarketShare = .26}, New SaleData() With {.State = "Wyoming", .Sales = 98012761.36, .SalesVsTarget = 0.00213708, .Profit = 4000000, .CustomersSatisfaction = 3.7, .MarketShare = .31}, New SaleData() With {.State = "Indiana", .Sales = 95976655.67, .SalesVsTarget = 0.024917714, .Profit = -7000000, .CustomersSatisfaction = 2.5, .MarketShare = .17}, New SaleData() With {.State = "Nevada", .Sales = 91535057.56, .SalesVsTarget = 0.028420047, .Profit = 23000000, .CustomersSatisfaction = 4.5, .MarketShare = .22}, New SaleData() With {.State = "Massachusetts", .Sales = 90602516.28, .SalesVsTarget = 0.013988886, .Profit = 12000000, .CustomersSatisfaction = 4.0, .MarketShare = .24}, New SaleData() With {.State = "Rhode Island", .Sales = 90548513.43, .SalesVsTarget = 0.013798557, .Profit = 21000000, .CustomersSatisfaction = 4.4, .MarketShare = .29}, New SaleData() With {.State = "Montana", .Sales = 89977272.49, .SalesVsTarget = -0.004951279, .Profit = -5000000, .CustomersSatisfaction = 2.0, .MarketShare = .13}, New SaleData() With {.State = "Alabama", .Sales = 88237187.77, .SalesVsTarget = -0.005941003, .Profit = 6000000, .CustomersSatisfaction = 4.6, .MarketShare = .15}, New SaleData() With {.State = "Georgia", .Sales = 88175277.25, .SalesVsTarget = 0.004525271, .Profit = 11000000, .CustomersSatisfaction = 4.2, .MarketShare = .24}, New SaleData() With {.State = "New York", .Sales = 87774749.80, .SalesVsTarget = 0.011495413, .Profit = 15000000, .CustomersSatisfaction = 3.9, .MarketShare = .30}, New SaleData() With {.State = "Texas", .Sales = 84291394.13, .SalesVsTarget = -0.009302101, .Profit = -20000000, .CustomersSatisfaction = 2.9, .MarketShare = .13}, New SaleData() With {.State = "Virginia", .Sales = 83582665.33, .SalesVsTarget = -0.005796166, .Profit = 8000000, .CustomersSatisfaction = 3.9, .MarketShare = .10}, New SaleData() With {.State = "South Carolina", .Sales = 83391264.21, .SalesVsTarget = 0.038427198, .Profit = 6000000, .CustomersSatisfaction = 4.4, .MarketShare = .28}, New SaleData() With {.State = "Missouri", .Sales = 82106438.59, .SalesVsTarget = -0.014408108, .Profit = 2000000, .CustomersSatisfaction = 3.2, .MarketShare = .18}, New SaleData() With {.State = "Florida", .Sales = 81751131.33, .SalesVsTarget = 0.011509847, .Profit = 7000000, .CustomersSatisfaction = 4.1, .MarketShare = .24}, New SaleData() With {.State = "Mississippi", .Sales = 81203810.96, .SalesVsTarget = 0.033294143, .Profit = 6000000, .CustomersSatisfaction = 4.4, .MarketShare = .31}, New SaleData() With {.State = "New Mexico", .Sales = 80452595.66, .SalesVsTarget = 0.012225542, .Profit = 13000000, .CustomersSatisfaction = 4.9, .MarketShare = .23}, New SaleData() With {.State = "Kentucky", .Sales = 79995544.60, .SalesVsTarget = 0.040305647, .Profit = 10000000, .CustomersSatisfaction = 4.6, .MarketShare = .27}, New SaleData() With {.State = "Connecticut", .Sales = 73220631.05, .SalesVsTarget = 0.033769282, .Profit = 8000000, .CustomersSatisfaction = 2.9, .MarketShare = .24}, New SaleData() With {.State = "Arizona", .Sales = 72989023.31, .SalesVsTarget = -0.009417676, .Profit = -4000000, .CustomersSatisfaction = 3.6, .MarketShare = .11}, New SaleData() With {.State = "Tennessee", .Sales = 72877959.11, .SalesVsTarget = 0.029150876, .Profit = 14000000, .CustomersSatisfaction = 4.9, .MarketShare = .25}, New SaleData() With {.State = "Colorado", .Sales = 71391979.17, .SalesVsTarget = 0.003629055, .Profit = 5000000, .CustomersSatisfaction = 4.1, .MarketShare = .28}, New SaleData() With {.State = "Oregon", .Sales = 70908060.11, .SalesVsTarget = 0.004207476, .Profit = 6000000, .CustomersSatisfaction = 4.5, .MarketShare = .23}, New SaleData() With {.State = "North Carolina", .Sales = 70896926.22, .SalesVsTarget = -0.011178166, .Profit = -17000000, .CustomersSatisfaction = 3.0, .MarketShare = .12}, New SaleData() With {.State = "Michigan", .Sales = 69466608.80, .SalesVsTarget = -0.008368982, .Profit = 3000000, .CustomersSatisfaction = 4.0, .MarketShare = .20}, New SaleData() With {.State = "Minnesota", .Sales = 66473670.35, .SalesVsTarget = 0.009992279, .Profit = 8000000, .CustomersSatisfaction = 4.2, .MarketShare = .19}}
        End Function
    End Module
End Namespace
