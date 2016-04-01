#r "packages/Suave/lib/net40/Suave.dll"
#r "packages/FSharp.Data/lib/net40/FSharp.Data.dll"
#r "packages/linqtotwitter/lib/net45/LinqToTwitter.net.dll"
#r "System.Linq.dll"

module Twitter = 

  open System
  open System.Net
  open System.Linq
  open Suave.Successful
  open FSharp.Data
  open LinqToTwitter

  let consumerKey = Environment.GetEnvironmentVariable("TWITTER_CONSUMER_KEY")
  let consumerSecret = Environment.GetEnvironmentVariable("TWITTER_CONSUMER_SECRET")


  let getTweets() =
    let credentials = new InMemoryCredentials()
    credentials.ConsumerKey <- consumerKey
    credentials.ConsumerSecret <- consumerSecret

    let auth = new ApplicationOnlyAuthorizer()
    auth.Credentials <- credentials

    auth.Authorize()
    ""
