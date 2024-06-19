﻿public class ContactController
{
    private ContactRepository _contactRepository;

    public ContactController(ContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public void Add(Contact contact)
    {
        if (contact.Name.Length > 0 && contact.PhoneNumbers.Count > 0)
        {
            _contactRepository.Add(contact);
        }
        else
        {
            throw new ArgumentNullException("Error, invalid record.");
        }
    }

    public void Update(Contact contact)
    {
        if (contact.PhoneNumbers.Count > 0 && contact.Name.Length > 0)
        {
            _contactRepository.Update(contact);
        }
        else
        {
            throw new ArgumentNullException("Error, can't update record. Invalid record.");
        }
    }

    public List<Contact> GetAll() => _contactRepository.GetAllContacts();
}
