    let mySeq1 = seq { 1.. 100 }
    let printSeq seq1 = Seq.iter (printf "%A ") seq1; printfn ""
    let seqResult = Seq.countBy (fun elem -> if elem % 3 = 0 then 0
                                             elif elem % 3 = 1 then 1
                                             else 2) mySeq1

    printSeq seqResult