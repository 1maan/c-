import random
import logging
from telegram.ext import Updater, CommandHandler, MessageHandler, Filters

# Set up logging
logging.basicConfig(format='%(asctime)s - %(name)s - %(levelname)s - %(message)s', level=logging.INFO)
logger = logging.getLogger(__name__)

# Define a function to handle the /start command
def start(update, context):
    update.message.reply_text('Welcome to the Gem00 Guess the Number game! I\'m thinking of a number between 1 and 100. Can you guess it?')

# Define a function to handle guesses
def guess(update, context):
    numberRn = context.user_data.get('numberRn')
    guessnumber = context.user_data.get('guessnumber')
    
    if not numberRn or not guessnumber:
        numberRn = random.randint(1, 100)
        guessnumber = 0
        context.user_data['numberRn'] = numberRn
        context.user_data['guessnumber'] = guessnumber
        update.message.reply_text('I\'m thinking of a number between 1 and 100. Can you guess it?')
    
    try:
        guess = int(update.message.text)
    except ValueError:
        update.message.reply_text('Please enter a valid integer.')
        return
    
    if guess < numberRn:
        update.message.reply_text('Too low.')
        context.user_data['guessnumber'] = guess
    elif guess == numberRn:
        update.message.reply_text('Congratulations! You guessed the number.')
        context.user_data.clear()
    elif guess > numberRn:
        update.message.reply_text('Too high.')
        context.user_data['guessnumber'] = guess

# Define a function to handle errors
def error(update, context):
    logger.warning('Update "%s" caused error "%s"', update, context.error)

def main():
    # Create an Updater object and attach it to your bot token
    updater = Updater('5969322590:AAF4yg9Yn0eSOfrcB4bDsTrIVQu3qYRZI90', use_context=True)

    # Register handlers for commands and messages
    updater.dispatcher.add_handler(CommandHandler('start', start))
    updater.dispatcher.add_handler(MessageHandler(Filters.text, guess))

    # Register an error handler
    updater.dispatcher.add_error_handler(error)

    # Start polling for updates from Telegram
    updater.start_polling()

    # Run the bot until you press Ctrl-C
    updater.idle()

if __name__ == '__main__':
    main()
