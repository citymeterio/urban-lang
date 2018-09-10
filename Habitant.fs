namespace urban_lang

module Civic =
    type Identity =
        Email
        | Card
        | SocialMedia
        | Municipal

    type Habitant =
        Anonymous of id:string
        | Identified of by:Identity
        | Decentralized // blockchain
        
    let hello name =
        printfn "Hello %s" name
