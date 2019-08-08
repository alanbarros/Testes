const Dev = require('../models/Dev');

module.exports = {
    async store(req, res){

        const { user } = req.headers;
        const { devId } = req.params;

        const loggedDev = await Dev.findById(user);
        const targetDev = await Dev.findById(devId);

        if(!targetDev){
            return res.status(400).json({ message : "Dev not exists"});
        }
        
        loggedDev.deslikes.push(targetDev._id);

        await loggedDev.save();

        return res.json(loggedDev);
    }
}