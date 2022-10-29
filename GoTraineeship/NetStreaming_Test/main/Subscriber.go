package main

import (
	"fmt"
	"stan_test/util"
	"time"

	"github.com/nats-io/stan.go"
)

func main() {

	sc, _ := stan.Connect("prod", "sub-1")
	defer sc.Close()

	d, _ := time.ParseDuration("1m")
	sc.Subscribe("orders", func(m *stan.Msg) {
		//fmt.Printf("Got: #{string(m.Data)}\n")
		fmt.Printf("Got: %s\n", string(m.Data))
	},
		//stan.DeliverAllAvailable())
		//stan.StartAtSequence(42))
		stan.StartAtTimeDelta(d))
	util.Block()
}
