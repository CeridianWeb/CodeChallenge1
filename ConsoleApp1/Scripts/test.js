/*!
 * @brief Argument Class
 * @param type:Object arg argument description
 */
function Argument(arg) {
}

/*!
 * @brief Get child arguments
 * @param type:String name arguments name
 * @return type:Array child arguments
 */
Argument.prototype.getArguments = function(name) {
}

/*!
 * @brief Get first child argument
 * @param type:String name argument name
 * @return type:Argument child argument
 */
Argument.prototype.getArgument = function(name) {
}

/*!
 * @brief Add child arguments
 * @param type:Argument arg argument
 */
Argument.prototype.addArgument = function(arg) {
}

/*!
 * @brief Command Class
 * @param type:Object cmd command description
 */
function Command(cmd) {
}

Command.prototype = Object.create(Argument.prototype);
Command.prototype.constructor = Command;

/*!
 * @brief Event Class
 * @param type:Object event event description
 */
function Event(event) {
}

Event.prototype = Object.create(Argument.prototype);
Event.prototype.constructor = Event;