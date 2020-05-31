// observer pattern maintains a list of objects based on events typically done by updating data based on the events
//e.g. publish subscribe methods in MeteorJS - publish info, objects or collections and then subscribe to it
class Car {
    constructor(gas) {
        this.gas = gas;
    }

    setGasLevel(val) {
        this.gas = val;
        this.notifyAll();
    }

    register(observer) {
        this.actions.push(observer);
    }

    unregister(observer) {
        this.actions.remove.filter(function(el) {
            return el !== observer;
        });
    }

    notifyAll() {
        return this.actions.forEach(function(el) {
            el.update(this);
        }.bind(this));
    }
}

class consumption {
    update(car) {
        car.gas = car.gas + 1;
    }
}
