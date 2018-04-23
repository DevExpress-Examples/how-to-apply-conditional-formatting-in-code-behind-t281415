Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Namespace ConditionalFormatting
    Public NotInheritable Class SaleOverviewDataGenerator

        Private Sub New()
        End Sub

        Public Shared Function GenerateSales() As SaleOverviewData()
            Return New SaleOverviewData() { _
                New SaleOverviewData("California", 467949484.42, 0.027697392, 44000000, 4.6,.34), _
                New SaleOverviewData("South Dakota", 458113868.36, 0.048206741, 27000000, 4.8,.32), _
                New SaleOverviewData("Ohio", 250772304.63, -0.028834951, -15000000, 3.4,.29), _
                New SaleOverviewData("Wisconsin", 182660621.53, 0.059826898, 14000000, 4.1,.22), _
                New SaleOverviewData("New Hampshire", 158710257.91, 0.01329949, 10000000, 4.0,.19), _
                New SaleOverviewData("Maine", 156032947.24, -0.099670575, -9000000, 2.9,.14), _
                New SaleOverviewData("Utah", 131496479.72, 0.044533577, 18000000, 4.7,.27), _
                New SaleOverviewData("Idaho", 119199535.50, 0.006545225, 14000000, 3.9,.30), _
                New SaleOverviewData("Illinois", 102480457.66, -0.003925837, 9000000, 4.2,.17), _
                New SaleOverviewData("Washington", 102301309.53, 0.024232883, 18000000, 4.6,.26), _
                New SaleOverviewData("Wyoming", 98012761.36, 0.00213708, 4000000, 3.7,.31), _
                New SaleOverviewData("Indiana", 95976655.67, 0.024917714, -7000000, 2.5,.17), _
                New SaleOverviewData("Nevada", 91535057.56, 0.028420047, 23000000, 4.5,.22), _
                New SaleOverviewData("Massachusetts", 90602516.28, 0.013988886, 12000000, 4.0,.24), _
                New SaleOverviewData("Rhode Island", 90548513.43, 0.013798557, 21000000, 4.4,.29), _
                New SaleOverviewData("Montana", 89977272.49, -0.004951279, -5000000, 2.0,.13), _
                New SaleOverviewData("Alabama", 88237187.77, -0.005941003, 6000000, 4.6,.15), _
                New SaleOverviewData("Georgia", 88175277.25, 0.004525271, 11000000, 4.2,.24), _
                New SaleOverviewData("New York", 87774749.80, 0.011495413, 15000000, 3.9,.30), _
                New SaleOverviewData("Texas", 84291394.13, -0.009302101, -20000000, 2.9,.13), _
                New SaleOverviewData("Virginia", 83582665.33, -0.005796166, 8000000, 3.9,.10), _
                New SaleOverviewData("South Carolina", 83391264.21, 0.038427198, 6000000, 4.4,.28), _
                New SaleOverviewData("Missouri", 82106438.59, -0.014408108, 2000000, 3.2,.18), _
                New SaleOverviewData("Florida", 81751131.33, 0.011509847, 7000000, 4.1,.24), _
                New SaleOverviewData("Mississippi", 81203810.96, 0.033294143, 6000000, 4.4,.31), _
                New SaleOverviewData("New Mexico", 80452595.66, 0.012225542, 13000000, 4.9,.23), _
                New SaleOverviewData("Kentucky", 79995544.60, 0.040305647, 10000000, 4.6,.27), _
                New SaleOverviewData("Connecticut", 73220631.05, 0.033769282, 8000000, 2.9,.24), _
                New SaleOverviewData("Arizona", 72989023.31, -0.009417676, -4000000, 3.6,.11), _
                New SaleOverviewData("Tennessee", 72877959.11, 0.029150876, 14000000, 4.9,.25), _
                New SaleOverviewData("Colorado", 71391979.17, 0.003629055, 5000000, 4.1,.28), _
                New SaleOverviewData("Oregon", 70908060.11, 0.004207476, 6000000, 4.5,.23), _
                New SaleOverviewData("North Carolina", 70896926.22, -0.011178166, -17000000, 3.0,.12), _
                New SaleOverviewData("Michigan", 69466608.80, -0.008368982, 3000000, 4.0,.20), _
                New SaleOverviewData("Minnesota", 66473670.35, 0.009992279, 8000000, 4.2,.19) _
            }
        End Function
    End Class
End Namespace
