
#light
open System.IO
open System.Net

let loadPrices ticker=

    let url ="http://ichart.finance.yahoo.com/table.csv?s=" + ticker + "&d=3&e=13&f=2012&g=d&a=2&b=13&c=1986&ignore=.csv"
    let request = WebRequest.Create(url)
    let response= request.GetResponse()
    let stream=response.GetResponseStream()
    let reader= new StreamReader(stream)
    let csv = reader.ReadToEnd()
    
    let prices = 
        csv.Split([|'\n'|]) 
        |> Seq.skip 1
        |> Seq.map (fun line -> line.Split([|','|])) 
        |> Seq.filter (fun values-> values|>Seq.length=7)
        |> Seq.map (fun values -> 
            System.DateTime.Parse(values.[0]),
            float values.[6])
    prices



